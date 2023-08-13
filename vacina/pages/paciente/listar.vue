<script setup>
import { ref } from "vue";
import axios from "axios";

const loading = ref(false);
const pacientes = ref([]);

async function getPacientes() {
  loading.value = true;
  try {
    const response = await axios.get("https://api-vacinacao.onrender.com/usuario", {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    });
    pacientes.value = response.data;
    loading.value = false;
  } catch (error) {
    if (error.response.status === 401) {
      window.location.href = "/logout";
    }
  }
}

onMounted(() => {
  getPacientes();
});
</script>

<template>
  <div class="bg-gray-900 min-h-screen p-6 md:p-24">
    <menu-search />
    <h1 class="text-xl md:text-3xl text-white font-bold mb-2">Pacientes cadastrados</h1>
    <listar-pacientes :pacientesList="pacientes" />
  </div>
</template>
