<script setup>
import { ref } from "vue";
const step = ref(0);

const nome = ref("");
const descricao = ref("");
const doses = ref(1);
const periodicidade = ref("");
const intervalo = ref(0);
const cadastranteIsAdmin = ref(false);
const steps = ["Identificação", "Periodicidade"];

onMounted(() => {
  if (localStorage.getItem("admin")) {
    cadastranteIsAdmin.value = localStorage.getItem("admin");
  }
});

function changestep(stepSelecionada) {
  step.value = stepSelecionada;
}

async function submit() {
  let response = await fetch("https://api-vacinacao.onrender.com/vacina", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      "Authorization": "Bearer " + localStorage.getItem("token"),
    },
    body: JSON.stringify({
      titulo: nome.value,
      descricao: descricao.value,
      doses: doses.value,
      periodicidade: periodicidade.value,
      intervalo: intervalo.value
    }),
  });
  let data = await response.json();
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
              Essas são suas informações de identificação da vacina
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-2">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="titulo" class="block text-sm font-medium text-white"
                >Nome</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="titulo"
                  id="titulo"
                  autocomplete="titulo"
                  v-model="nome"
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="descricao" class="block text-sm font-medium text-white"
                >Descrição</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="descricao"
                  id="descricao"
                  autocomplete="descricao"
                  v-model="descricao"
                  class="input-vacina"
                />
              </div>
            </div>
          </div>
        </div>

        <div v-show="step == 1">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Periodicidade</h3>
            <p class="mt-1 text-sm text-gray-500">
              Essas são as informações de periodicidade da vacina.
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-3">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="periodicidade" class="block text-sm font-medium text-white"
                >Periodicade</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <select class="input-vacina" v-model="periodicidade" id="periodicidade">
                  <option disabled value="">Selecione</option>
                  <option value="dias">Dias</option>
                  <option value="meses">Meses</option>
                  <option value="anos">Anos</option>
                </select>
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="intervalo" class="block text-sm font-medium text-white"
                >Intervalo</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="number"
                  name="intervalo"
                  id="intervalo"
                  autocomplete="intervalo"
                  v-model="intervalo"
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="doses" class="block text-sm font-medium text-white"
                >Quantidade de doses</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="number"
                  name="doses"
                  id="doses"
                  autocomplete="doses"
                  v-model="doses"
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
            @click="step--"
            type="button"
            class="ml-3 inline-flex justify-center rounded-md border border-transparent bg-gray-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
          >
            Voltar
          </button>
          <button
            v-if="step !== 1"
            @click="step++"
            type="button"
            class="ml-3 inline-flex justify-center rounded-md border border-transparent bg-indigo-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
          >
            Próximo
          </button>
          <button
            v-if="step === 1"
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
