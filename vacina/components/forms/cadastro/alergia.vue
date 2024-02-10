<script setup>
import { ref } from "vue";
const step = ref(0);
const nome = ref("");
const steps = [
  "Alergia"
]
function changestep(stepSelecionada) {
  step.value = stepSelecionada;
}

async function submit() {
  let response = await fetch("https://api-vacinacao.onrender.com/alergia", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      "Authorization": "Bearer " + localStorage.getItem("token"),
    },
    body: JSON.stringify({
      nome: nome.value,
    }),
  });
  let data = await response.json();
  console.log(data);
}
</script>

<template>
  <div>
    <nav-steps :steps="steps" :currentStep="step" @changeStep="changestep" />
    <form class="space-y-8 divide-y divide-gray-200 mt-4 md:mt-20">
      <div class="space-y-8">
        <div v-show="step == 0">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Identificação</h3>
            <p class="mt-1 text-sm text-gray-500">
              Essas são suas informações de identificação da alergia
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-1">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="username" class="block text-sm font-medium text-white"
                >Nome</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="username"
                  id="username"
                  autocomplete="username"
                  v-model="nome"
                  class="input-vacina"
                />
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="pt-5">
        <div class="flex justify-end">
          <button
            v-if="step !== 0"
            @click="step++"
            type="button"
            class="ml-3 inline-flex justify-center rounded-md border border-transparent bg-indigo-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
          >
            Próximo
          </button>
          <button
            v-if="step === 0"
            @click="submit"
            type="button"
            class="ml-3 inline-flex justify-center rounded-md border border-transparent bg-indigo-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
          >
            Concluir cadastro
          </button>
        </div>
      </div>
    </form>
  </div>
</template>
