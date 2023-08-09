<script setup>
import { ref } from "vue";
import axios from "axios";
const loading = ref(false);
const email = ref("");
const password = ref("");

async function submit() {
  loading.value = true;
  try {
    const { data } = await axios.post("https://api-vacinacao.onrender.com/login", {
      email: email.value,
      senha: password.value,
    });
    localStorage.setItem("token", data.accessToken);
    localStorage.setItem("user", JSON.stringify(data.usuarioId));
    if (data.accessToken) {
      window.location.href = "/perfil";
    }
  } catch (error) {
    alert("Email ou senha incorretos");
  } finally {
    loading.value = false;
  }
}

async function axiosGetHealthCheck() {
  await axios.get("https://api-vacinacao.onrender.com/_health");
}

onMounted(() => {
  axiosGetHealthCheck();
  if (localStorage.getItem("token")) {
    window.location.href = "/perfil";
  }
});
</script>

<template>
  <div
    class="flex min-h-screen flex-1 flex-col justify-center px-6 py-12 lg:px-8 bg-gray-900"
  >
    <load v-show="loading" />
    <div class="sm:mx-auto sm:w-full sm:max-w-sm">
      <img
        class="mx-auto h-10 w-auto"
        src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600"
        alt="Your Company"
      />
      <h2
        class="mt-10 text-center text-2xl font-bold leading-9 tracking-tight text-white"
      >
        Entre na sua conta
      </h2>
    </div>

    <div class="mt-10 sm:mx-auto sm:w-full sm:max-w-sm">
      <form class="space-y-6">
        <div>
          <label for="email" class="block text-sm font-medium leading-6 text-white"
            >Email address</label
          >
          <div class="mt-2">
            <input
              id="email"
              name="email"
              type="email"
              autocomplete="email"
              v-model="email"
              required=""
              class="block w-full rounded-md border-0 px-2 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
            />
          </div>
        </div>

        <div>
          <div class="flex items-center justify-between">
            <label for="password" class="block text-sm font-medium leading-6 text-white"
              >Password</label
            >
            <div class="text-sm">
              <a v-if="1==2" href="#" class="font-semibold text-indigo-600 hover:text-indigo-500"
                >Esqueceu sua senha?</a
              >
            </div>
          </div>
          <div class="mt-2">
            <input
              id="password"
              name="password"
              type="password"
              v-model="password"
              autocomplete="current-password"
              required=""
              class="block w-full rounded-md border-0 px-2 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
            />
          </div>
        </div>

        <div>
          <button
            type="button"
            @click="submit()"
            class="flex w-full justify-center rounded-md bg-indigo-600 px-3 py-1.5 text-sm font-semibold leading-6 text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
          >
            Entrar
          </button>
        </div>
      </form>
      <Load v-show="loading" />

      <p class="mt-10 text-center text-sm text-gray-500">
        Não tem conta?
        {{ " " }}
        <a
          href="/registro"
          class="font-semibold leading-6 text-indigo-600 hover:text-indigo-500"
          >Registre-se</a
        >
      </p>
    </div>
  </div>
</template>
