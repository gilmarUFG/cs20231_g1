<script setup>
import { ref } from "vue";
import axios from "axios";

const loading = ref(false);
const vacinas = ref([]);

async function getVacinas() {
  loading.value = true;
  try {
    const response = await axios.get("https://api-vacinacao.onrender.com/vacina", {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    });
    vacinas.value = response.data;
    loading.value = false;
  } catch (error) {
    if (error.response.status === 401) {
      window.location.href = "/logout";
    }
  }
}

onMounted(() => {
  getVacinas();
});
</script>

<template>
  <div class="bg-gray-900 min-h-screen p-6 md:p-24">
    <menu-search />
    <h1 class="text-xl md:text-3xl text-white font-bold mb-2">Vacinas cadastradas</h1>
    <listar-vacinas :vacinasList="vacinas" />
  </div>
</template>
