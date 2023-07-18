<script setup>
import { ref, defineProps } from "vue";
import axios from "axios";

const listAgenda = ref([]);

const getAgenda = async () => {
  const response = await axios.get(
    "https://api-vacinacao.onrender.com/agenda",
    {
      headers: {
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    }
  );
  listAgenda.value = response.data;
};

onMounted(() => {
  getAgenda();
});
</script>

<template>
  <div
    class="bg-gray-900 min-h-screen p-8 md:p-24 items-center justify-center min-w-screen"
  >
    <listar-agenda  />
    <layout-menu />
  </div>
</template>
