<script setup>
import { ref } from "vue";
import axios from "axios";

const user = ref({});
const loading = ref(false);

async function getUserData() {
  loading.value = true;
  const response = await axios.get(
    "https://api-vacinacao.onrender.com/usuario/" + localStorage.getItem("user"),
    {
      headers: {
        Authorization: `Bearer ${localStorage.getItem("token")}`,
      },
    }
  );
  user.value = response.data;
  if (user.value) {
    localStorage.setItem("admin", user.value.isAdmin);
  }
  loading.value = false;
}

onMounted(() => {
  if (!localStorage.getItem("token")) {
    router.push("/login");
  }
  getUserData();
});
</script>

<template>
  <div>
    <menu-flyout />
    <div
      class="min-w-screen min-h-screen bg-gray-900 flex items-center justify-center px-5 py-5"
    >
      <load v-if="loading" />
      <cards-perfil :user="user" />
      <menu-search v-if="!loading" />
    </div>
  </div>
</template>
