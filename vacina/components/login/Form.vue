<template>
  <form>
    <div class="mb-6">
      <label
        for="email"
        class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
        >Your email</label
      >
      <input
        type="email"
        v-model="email"
        id="email"
        class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-gray-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
        placeholder="name@flowbite.com"
        required
      />
    </div>
    <div class="mb-6">
      <label
        for="password"
        class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
        >Your password</label
      >
      <input
        type="password"
        v-model="password"
        id="password"
        class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
        required
      />
    </div>
    <button
      type="button"
      @click="login()"
      class="text-white bg-gray-700 hover:bg-gray-800 focus:ring-4 focus:outline-none focus:ring-gray-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-gray-600 dark:hover:bg-gray-700 dark:focus:ring-gray-800"
    >
      Submit
    </button>
  </form>
</template>

<script setup>
import { ref } from "vue";
defineProps({
  email: String,
  password: String,
  loading: ref(false),
});

async function login() {
  console.log("login");
  const response = await fetch("https://api-vacinacao.onrender.com/Login", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      email: email.value,
      senha: password.value,
    }),
  });
  const data = await response.json();
  handle_response_login(data);
}

function handle_response_login(data) {
  const { accessToken } = data;
  localStorage.setItem("token", JSON.stringify(accessToken));
  localStorage.setItem("userId", JSON.stringify(1));
  window.location.href = "/agendamento";
}
</script>
