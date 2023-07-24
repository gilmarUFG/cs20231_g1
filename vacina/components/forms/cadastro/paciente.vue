<script setup>
import { ref } from "vue";
const step = ref(0);

const nome = ref("");
const email = ref("");
const senha = ref("");
const admin = ref(false);
const genero = ref("");
const dataNascimento = ref("");
const cep = ref(null);
const numero = ref("");
const estado = ref("");
const setor = ref("");
const cidade = ref("");
const logradouro = ref("");
const cadastranteIsAdmin = ref(false);
const steps = [
  "Perfil",
  "Dados Pessoais",
  "Endereço"
]

onMounted(() => {
  if (localStorage.getItem("admin")) {
    cadastranteIsAdmin.value = localStorage.getItem("admin");
  }
});

function changestep(stepSelecionada) {
  step.value = stepSelecionada;
}

function setAdmin(retornoToggle) {
  admin.value = retornoToggle;
}

async function getCep() {
  let response = await fetch("https://viacep.com.br/ws/" + cep.value + "/json/");
  let data = await response.json();
  estado.value = data.uf;
  cidade.value = data.localidade;
  logradouro.value = data.logradouro;
  setor.value = data.bairro;
}

async function submit() {
  let url = "https://api-vacinacao.onrender.com/usuario";
  if (localStorage.getItem("admin")) url = "https://api-vacinacao.onrender.com/usuario/admin";
  let headers = {
    "Content-Type": "application/json",
  };
  if (localStorage.getItem("token")) headers.Authorization = "Bearer " + localStorage.getItem("token");
  let response = await fetch(url, {
    method: "POST",
    headers: headers,
    body: JSON.stringify({
      nome: nome.value,
      email: email.value,
      senha: senha.value,
      sexo: genero.value,
      dataNascimento: dataNascimento.value,
      cep: cep.value,
      numero: numero.value,
      uf: estado.value,
      cidade: cidade.value,
      logradouro: logradouro.value,
      isAdmin: admin.value,
      setor: setor.value,
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
            <h3 class="text-lg font-medium leading-6 text-white">Perfil</h3>
            <p class="mt-1 text-sm text-gray-500">
              Essas são suas informações do seu perfil e seus dados de acesso.
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-3">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="username" class="block text-sm font-medium text-white"
                >Seu nome</label
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
            <div class="sm:col-span-4 lg:col-auto">
              <label for="email" class="block text-sm font-medium text-white"
                >Seu email</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="email"
                  id="email"
                  autocomplete="email"
                  v-model="email"
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="password" class="block text-sm font-medium text-white"
                >Sua senha</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="password"
                  name="password"
                  id="password"
                  autocomplete="password"
                  v-model="senha"
                  class="input-vacina"
                />
              </div>
            </div>
            <div v-if="cadastranteIsAdmin" class="flex items-center flex-row">
              <forms-elements-toggle @switch="setAdmin" />
              &nbsp; &nbsp;
              <span class="text-white"> Usuário administrador? </span>
            </div>
          </div>
        </div>

        <div v-show="step == 1">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Dados pessoais</h3>
            <p class="mt-1 text-sm text-gray-500">Essas são suas informações pessoais.</p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-2">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="genero" class="block text-sm font-medium text-white"
                >Genero</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <select class="input-vacina" v-model="genero" id="genero">
                  <option disabled value="">Selecione</option>
                  <option value="m">Masculino</option>
                  <option value="f">Feminino</option>
                </select>
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="datanascimento" class="block text-sm font-medium text-white"
                >Data de nascimento</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="date"
                  name="datanascimento"
                  id="datanascimento"
                  autocomplete="datanascimento"
                  v-model="dataNascimento"
                  class="input-vacina"
                />
              </div>
            </div>
          </div>
        </div>

        <div v-show="step == 2">
          <div>
            <h3 class="text-lg font-medium leading-6 text-white">Dados do endereço</h3>
            <p class="mt-1 text-sm text-gray-500">
              Essas são as informações do seu endereço
            </p>
          </div>

          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-3">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="cep" class="block text-sm font-medium text-white">CEP</label>
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  @blur="getCep()"
                  type="number"
                  name="cep"
                  id="cep"
                  autocomplete="cep"
                  v-model="cep"
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="numero" class="block text-sm font-medium text-white"
                >Número</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="number"
                  name="numero"
                  id="numero"
                  v-model="numero"
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="setor" class="block text-sm font-medium text-white"
                >Bairro</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="setor"
                  id="setor"
                  v-model="setor"
                  class="input-vacina"
                />
              </div>
            </div>
          </div>
          <div class="mt-6 grid grid-cols-1 gap-y-6 gap-x-4 sm:grid-cols-3">
            <div class="sm:col-span-4 lg:col-auto">
              <label for="estado" class="block text-sm font-medium text-white"
                >Estado</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="estado"
                  id="estado"
                  autocomplete="estado"
                  v-model="estado"
                  readonly
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="cidade" class="block text-sm font-medium text-white"
                >Cidade</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="cidade"
                  id="cidade"
                  autocomplete="cidade"
                  v-model="cidade"
                  readonly
                  class="input-vacina"
                />
              </div>
            </div>
            <div class="sm:col-span-4 lg:col-auto">
              <label for="logradouro" class="block text-sm font-medium text-white"
                >Logradouro</label
              >
              <div class="mt-1 flex rounded-md shadow-sm">
                <input
                  type="text"
                  name="logradouro"
                  id="logradouro"
                  autocomplete="logradouro"
                  v-model="logradouro"
                  readonly
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
