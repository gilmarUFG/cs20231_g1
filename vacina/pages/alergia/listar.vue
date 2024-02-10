<script setup>
import { ref } from "vue";
import axios from "axios";

const loading = ref(false);
const alergias = ref([]);

async function getAlergias() {
  loading.value = true;
  try {
    const response = await axios.get("https://api-vacinacao.onrender.com/alergia", {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    });
    alergias.value = response.data;
    loading.value = false;
  } catch (error) {
    if (error.response.status === 401) {
      window.location.href = "/logout";
    }
  }
}

onMounted(() => {
  getAlergias();
});
</script>

<template>
  <div>
    <menu-flyout />
    <div class="bg-gray-900 min-h-screen p-6 md:p-24">
      <h1 class="text-xl md:text-3xl text-white font-bold mb-2">Alergias cadastradas</h1>
      <listar-alergias :alergiasList="alergias" />
    </div>
  </div>
</template>
