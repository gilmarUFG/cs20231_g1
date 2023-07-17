<template>
  <div class="flex flex-1 flex-col justify-center px-6 py-12 lg:px-8 bg-gray-900">
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
      <form
        @submit.prevent="submitForm"
        class="gap-4 grid grid-cols-2 grid-rows-5 items-start"
      >
        <div>
          <div>
            <label for="nome" class="block text-sm font-medium leading-6 text-white"
              >Nome</label
            >
            <div class="mt-2">
              <input
                id="nome"
                name="nome"
                type="text"
                required=""
                v-model="formData.nome"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <label
              for="dataNascimento"
              class="block text-sm font-medium leading-6 text-white"
              >Data de Nascimento</label
            >
            <div class="mt-2">
              <input
                id="dataNascimento"
                name="dataNascimento"
                type="date"
                required=""
                v-model="formData.dataNascimento"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <label for="sexo" class="block text-sm font-medium leading-6 text-white"
              >Sexo</label
            >
            <div class="mt-2">
              <select
                id="sexo"
                name="sexo"
                required=""
                v-model="formData.sexo"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              >
                <option value="m">Masculino</option>
                <option value="f">Feminino</option>
              </select>
            </div>
          </div>

          <div>
            <label for="logradouro" class="block text-sm font-medium leading-6 text-white"
              >Logradouro</label
            >
            <div class="mt-2">
              <input
                id="logradouro"
                name="logradouro"
                type="text"
                required=""
                v-model="formData.logradouro"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <div>
              <label for="numero" class="block text-sm font-medium leading-6 text-white"
                >Número</label
              >
              <div class="mt-2">
                <input
                  id="numero"
                  name="numero"
                  type="number"
                  required=""
                  v-model="formData.numero"
                  class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
                />
              </div>
            </div>
          </div>
        </div>

        <div>
          <div>
            <label for="setor" class="block text-sm font-medium leading-6 text-white"
              >Setor</label
            >
            <div class="mt-2">
              <input
                id="setor"
                name="setor"
                type="text"
                required=""
                v-model="formData.setor"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <label for="cidade" class="block text-sm font-medium leading-6 text-white"
              >Cidade</label
            >
            <div class="mt-2">
              <input
                id="cidade"
                name="cidade"
                type="text"
                required=""
                v-model="formData.cidade"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <label for="uf" class="block text-sm font-medium leading-6 text-white"
              >UF</label
            >
            <div class="mt-2">
              <input
                id="uf"
                name="uf"
                type="text"
                required=""
                v-model="formData.uf"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <label for="email" class="block text-sm font-medium leading-6 text-white"
              >Email</label
            >
            <div class="mt-2">
              <input
                id="email"
                name="email"
                type="email"
                required=""
                v-model="formData.email"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>

          <div>
            <label for="senha" class="block text-sm font-medium leading-6 text-white"
              >Senha</label
            >
            <div class="mt-2">
              <input
                id="senha"
                name="senha"
                type="password"
                required=""
                v-model="formData.senha"
                class="block w-full rounded-md border-0 py-1.5 text-black shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
              />
            </div>
          </div>
        </div>

        <div class="w-full">
          <button
            type="submit"
            class="flex w-full justify-center rounded-md bg-indigo-600 px-3 py-1.5 text-sm font-semibold leading-6 text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
          >
            Entrar
          </button>
        </div>
      </form>

      <p class="mt-10 text-center text-sm text-gray-500">
        Já possui conta? {{ " " }}
        <a
          href="/login"
          class="font-semibold leading-6 text-indigo-600 hover:text-indigo-500"
          >Entre aqui</a
        >
      </p>
    </div>
    <Load v-show="loading" />
  </div>
</template>

<script setup>
import { ref } from "vue";
const loading = ref(false);
const formData = ref({
  nome: "",
  dataNascimento: "",
  sexo: "",
  logradouro: "",
  numero: null,
  setor: "",
  cidade: "",
  uf: "",
  email: "",
  senha: "",
});

async function submitForm() {
  // Aqui você pode enviar os dados do formulário para o servidor
  // usando uma chamada HTTP, como axios ou fetch
  try {
    loading.value = true;
    // Enviar os dados para o servidor
    await enviarDadosParaServidor(formData.value);
    // Limpar os campos do formulário após o envio bem-sucedido
    formData.value = {
      nome: "",
      dataNascimento: "",
      sexo: "",
      logradouro: "",
      numero: null,
      setor: "",
      cidade: "",
      uf: "",
      email: "",
      senha: "",
    };
    loading.value = false;
  } catch (error) {
    console.error(error);
    loading.value = false;
  }
}

async function enviarDadosParaServidor(data) {
  // Implemente aqui a lógica para enviar os dados para o servidor
  // Você pode usar uma chamada HTTP, como axios ou fetch, para enviar os dados
  // para o backend ou fazer qualquer outra ação necessária.
  // Exemplo:
  // await axios.post('/api/registrar', data);
}
</script>
