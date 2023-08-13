<script setup>
import { ref } from "vue";

const options = ref([]);
const optionsFiltrado = ref([]);
const ADMIN = "admin";
const GERAL = "geral";

options.value = [
  ["Listar usuários", "/paciente/listar", ADMIN],
  ["Listar Agenda", "/agenda/listar", ADMIN],
  ["Listar Vacina", "/vacina/listar", ADMIN],
  ["Listar Alergia", "/alergia/listar", ADMIN],
  ["Cadastrar Vacina", "/vacina/cadastro", ADMIN],
  ["Cadastrar Usuário", "/paciente/cadastro", ADMIN],
  ["Cadastrar Alergia", "/alergia/cadastro", ADMIN],
  ["Cadastrar Agendamento", "/agenda/cadastro", GERAL],
  ["Perfil", "/perfil", GERAL],
  ["Logout", "/logout", GERAL],
];

onBeforeMount(() => {
  optionsFiltrado.value = options.value.filter((option) => {
    return validarSeItemSeraMostrado(option[2]);
  });
});

function validarSeItemSeraMostrado(isAdmin) {
  if (localStorage.getItem("admin")) {
    return true;
  } else {
    return isAdmin == GERAL;
  }
}
</script>

<template>
  <div>
    <div class="relative z-10" role="dialog" aria-modal="true">
      <!--
    Background backdrop, show/hide based on modal state.

    Entering: "ease-out duration-300"
      From: "opacity-0"
      To: "opacity-100"
    Leaving: "ease-in duration-200"
      From: "opacity-100"
      To: "opacity-0"
  -->
      <div class="fixed inset-0 bg-gray-500 bg-opacity-25 transition-opacity"></div>

      <div class="fixed inset-0 z-10 overflow-y-auto p-4 sm:p-6 md:p-20">
        <!--
      Command palette, show/hide based on modal state.

      Entering: "ease-out duration-300"
        From: "opacity-0 scale-95"
        To: "opacity-100 scale-100"
      Leaving: "ease-in duration-200"
        From: "opacity-100 scale-100"
        To: "opacity-0 scale-95"
    -->
        <div
          class="mx-auto max-w-xl transform divide-y divide-gray-100 overflow-hidden rounded-xl bg-white shadow-2xl ring-1 ring-black ring-opacity-5 transition-all"
        >
          <!-- <div class="relative">
          <svg
            class="pointer-events-none absolute top-3.5 left-4 h-5 w-5 text-gray-400"
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 20 20"
            fill="currentColor"
            aria-hidden="true"
          >
            <path
              fill-rule="evenodd"
              d="M9 3.5a5.5 5.5 0 100 11 5.5 5.5 0 000-11zM2 9a7 7 0 1112.452 4.391l3.328 3.329a.75.75 0 11-1.06 1.06l-3.329-3.328A7 7 0 012 9z"
              clip-rule="evenodd"
            />
          </svg>
          <input
            type="text"
            class="h-12 w-full border-0 bg-transparent pl-11 pr-4 text-gray-800 placeholder-gray-400 focus:ring-0 sm:text-sm"
            placeholder="Search..."
            role="combobox"
            aria-expanded="false"
            aria-controls="options"
          />
        </div> -->

          <!-- Results, show/hide based on command palette state -->
          <ul
            class="max-h-72 scroll-py-2 overflow-y-auto py-2 text-sm text-gray-800"
            id="options"
            role="listbox"
            v-for="option in optionsFiltrado"
            :key="option"
          >
            <!-- Active: "bg-indigo-600 text-white" -->
            <a :href="option[1]">
              <li
                class="cursor-default select-none px-4 py-2"
                id="option-1"
                role="option"
                tabindex="-1"
              >
                {{ option[0] }}
              </li>
            </a>
          </ul>
          <!-- Empty state, show/hide based on command palette state -->
          <!-- <p class="p-4 text-sm text-gray-500">No people found.</p> -->
        </div>
      </div>
    </div>
  </div>
</template>
