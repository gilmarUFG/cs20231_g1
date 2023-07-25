<script setup>
import { ref, defineProps } from "vue";

const props = defineProps({
  item: {
    type: Array,
  },
});
</script>

<template>
  <li class="relative flex space-x-6 py-6 xl:static">
    <div class="flex-auto">
      <h3 class="pr-10 font-semibold text-white xl:pr-0">{{ item.vacina.titulo }} | {{ item.vacina.descricao }}</h3>
      <dl class="mt-2 flex flex-col text-gray-500 xl:flex-row">
        <div class="flex items-start space-x-3">
          <dt class="mt-0.5">
            <span class="sr-only">Date</span>
            <!-- Heroicon name: mini/calendar -->
            <svg
              class="h-5 w-5 text-gray-400"
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 20 20"
              fill="currentColor"
              aria-hidden="true"
            >
              <path
                fill-rule="evenodd"
                d="M5.75 2a.75.75 0 01.75.75V4h7V2.75a.75.75 0 011.5 0V4h.25A2.75 2.75 0 0118 6.75v8.5A2.75 2.75 0 0115.25 18H4.75A2.75 2.75 0 012 15.25v-8.5A2.75 2.75 0 014.75 4H5V2.75A.75.75 0 015.75 2zm-1 5.5c-.69 0-1.25.56-1.25 1.25v6.5c0 .69.56 1.25 1.25 1.25h10.5c.69 0 1.25-.56 1.25-1.25v-6.5c0-.69-.56-1.25-1.25-1.25H4.75z"
                clip-rule="evenodd"
              />
            </svg>
          </dt>
          <dd>
            <time :datetime="item.data">{{ item.data }}</time>
          </dd>
        </div>
        <div
          class="mt-2 flex items-start space-x-3 xl:mt-0 xl:ml-3.5 xl:border-l xl:border-gray-400 xl:border-opacity-50 xl:pl-3.5"
        >
          <dt class="mt-0.5">
            <span class="sr-only">Paciente:</span>
            <!-- Heroicon name: mini/map-pin -->
            <svg
              xmlns="http://www.w3.org/2000/svg"
              fill="none"
              viewBox="0 0 24 24"
              stroke-width="1.5"
              stroke="currentColor"
              class="w-6 h-6"
            >
              <path
                stroke-linecap="round"
                stroke-linejoin="round"
                d="M15.75 6a3.75 3.75 0 11-7.5 0 3.75 3.75 0 017.5 0zM4.501 20.118a7.5 7.5 0 0114.998 0A17.933 17.933 0 0112 21.75c-2.676 0-5.216-.584-7.499-1.632z"
              />
            </svg>
          </dt>
          <dd>{{ item.usuario.nome }}</dd>
        </div>
      </dl>
    </div>
    <menu-edit-cancel />
  </li>
</template>
