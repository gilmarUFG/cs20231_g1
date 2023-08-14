<script setup>
import { ref } from "vue";
const step = ref(0);

const idUsuario = ref(0);
const idVacina = ref(0);
const time = ref(0);
const dia = ref("");
const listaUsuarios = ref([]);
const listaVacinas = ref([]);
const steps = ["Usuario", "Vacina", "Data"];

onMounted(() => {
  if (localStorage.getItem("admin") == "false") {
    step.value = 1;
    idUsuario.value = localStorage.getItem("userId");
    document.getElementById("usuario").disabled = true;
  }
  getUsuarios();
  getVacinas();
});

function changestep(stepSelecionada) {
  if (stepSelecionada == 0 && localStorage.getItem("admin") == "false") {
    return;
  }
  step.value = stepSelecionada;
}

async function getUsuarios() {
  let response = await fetch("https://api-vacinacao.onrender.com/usuario", {
    headers: {
      Authorization: "Bearer " + localStorage.getItem("token"),
    },
  });
  listaUsuarios.value = await response.json();
}

async function getVacinas() {
  let response = await fetch("https://api-vacinacao.onrender.com/vacina", {
    headers: {
      Authorization: "Bearer " + localStorage.getItem("token"),
    },
  });
  listaVacinas.value = await response.json();
}

async function submit() {
  let response = await fetch("https://api-vacinacao.onrender.com/agenda", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      Authorization: "Bearer " + localStorage.getItem("token"),
    },
    body: JSON.stringify({
      usuarioId: idUsuario.value,
      vacinaId: idVacina.value,
      data: dia.value + "T" + time.value + ":00Z",
    }),
  });
  if (response.status === 201) {
    alert("Agendamento cadastrado com sucesso!");
    window.location.href = "/agenda/listar";
  } else {
    alert("Erro ao cadastrar agendamento!");
  }
}
</script>

<template>
  <div>
    <nav-steps :steps="steps" :currentStep="step" @changeStep="changestep" />
    <form class="space-y-8 divide-y divide-gray-200 mt-4 md:mt-20">
      <div class="space-y-8">
        <div v-show="step == 0">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Paciente</h3>
            <p class="mt-1 text-sm text-gray-500">
              Qual usuário você deseja agendar a vacinação?
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-1">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="username" class="block text-sm font-medium text-white"
                >Usuario</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <select
                  class="input-vacina"
                  v-model="idUsuario"
                  name="usuario"
                  id="usuario"
                >
                  <option disabled value="">Selecione</option>
                  <option
                    v-for="usuario in listaUsuarios"
                    :key="usuario.id"
                    :value="usuario.id"
                  >
                    {{ usuario.nome }}
                  </option>
                </select>
              </div>
            </div>
          </div>
        </div>

        <div v-show="step == 1">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Vacina</h3>
            <p class="mt-1 text-sm text-gray-500">
              Qual vacina você deseja agendar a vacinação?
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-1">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="vacina" class="block text-sm font-medium text-white"
                >Vacina</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <select class="input-vacina" v-model="idVacina" name="vacina" id="vacina">
                  <option disabled value="">Selecione</option>
                  <option
                    v-for="vacina in listaVacinas"
                    :key="vacina.id"
                    :value="vacina.id"
                  >
                    {{ vacina.titulo }}
                  </option>
                </select>
              </div>
            </div>
          </div>
        </div>

        <div v-show="step == 2">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Data</h3>
            <p class="mt-1 text-sm text-gray-500">
              Qual data e hora você deseja agendar a vacinação?
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-2">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="dia" class="block text-sm font-medium text-white">Data</label>
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="date"
                  name="dia"
                  id="dia"
                  v-model="dia"
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="time" class="block text-sm font-medium text-white">Hora</label>
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="time"
                  name="time"
                  id="time"
                  min="08:00"
                  max="18:00"
                  v-model="time"
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
            @click="step--"
            type="button"
            class="ml-3 inline-flex justify-center rounded-md border border-transparent bg-gray-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
          >
            Voltar
          </button>
          <button
            v-if="step !== 2"
            @click="step++"
            type="button"
            class="ml-3 inline-flex justify-center rounded-md border border-transparent bg-indigo-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
          >
            Próximo
          </button>
          <button
            v-if="step === 2"
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
