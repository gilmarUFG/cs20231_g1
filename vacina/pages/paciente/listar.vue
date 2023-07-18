<script setup>
import { ref } from "vue";
import axios from "axios";

const loading = ref(false);
const pacientes = ref([]);

async function getPacientes() {
  loading.value = true;
  const response = await axios.get("https://api-vacinacao.onrender.com/paciente", {
    headers: {
      Authorization: "Bearer " + localStorage.getItem("token"),
    },
  });
  pacientes.value = response.data;
  loading.value = false;
};

onMounted(() => {
  getPacientes();
});
</script>

<template>
  <div class="bg-gray-900 min-h-screen p-6 md:p-24">
    <h1 class="text-xl md:text-3xl text-white font-bold mb-2">Pacientes cadastrados</h1>
    <listar-pacientes />
    <layout-menu />
  </div>
</template>
