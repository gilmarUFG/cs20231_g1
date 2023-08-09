<script setup>
import { ref, defineProps } from "vue";
import axios from "axios";
import { HttpTransportType, HubConnection, HubConnectionBuilder } from "@aspnet/signalr";

const listAgenda = ref([]);

const getAgenda = async () => {
  try {
    const response = await axios.get("https://api-vacinacao.onrender.com/agenda/usuario/?usuarioId=" + localStorage.getItem("user"), {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    });
    listAgenda.value = response.data;
  } catch (error) {
    if (error.response.status === 401) {
      window.location.href = "/logout";
    }
  }
};

onMounted(() => {
  getAgenda();
});

// essa connection precisa de um skip negociate
const connection = new HubConnectionBuilder()
  .withUrl("https://api-vacinacao.onrender.com/hub", {
    skipNegotiation: true,
    transport: HttpTransportType.WebSockets,
  })
  .build();

connection.start().then(() => {
  console.log("Conectado");
});

// aqui a agenda nova será concatenada com a lista de agendas
connection.on("NovosAgendamentos", (agenda) => {
  listAgenda.value = listAgenda.value.concat(agenda);
});
</script>

<template>
  <div
    class="bg-gray-900 min-h-screen p-8 md:p-24 items-center justify-center min-w-screen"
  >
    <menu-search />
    <listar-agendas :agendas="listAgenda" />
  </div>
</template>
