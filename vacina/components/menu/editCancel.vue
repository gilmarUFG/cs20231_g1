<script setup>
import { ref } from "vue";

const isOpen = ref(false);
</script>

<template>
  <div
    class="absolute top-6 right-0 xl:relative xl:top-auto xl:right-auto xl:self-center"
  >
    <div>
      <button
        @click="isOpen = !isOpen"
        type="button"
        class="-m-2 flex items-center rounded-full p-2 text-gray-500 hover:text-gray-600"
        id="menu-0-button"
        aria-expanded="false"
        aria-haspopup="true"
      >
        <span class="sr-only">Open options</span>
        <!-- Heroicon name: mini/ellipsis-horizontal -->
        <svg
          class="h-5 w-5"
          xmlns="http://www.w3.org/2000/svg"
          viewBox="0 0 20 20"
          fill="currentColor"
          aria-hidden="true"
        >
          <path
            d="M3 10a1.5 1.5 0 113 0 1.5 1.5 0 01-3 0zM8.5 10a1.5 1.5 0 113 0 1.5 1.5 0 01-3 0zM15.5 8.5a1.5 1.5 0 100 3 1.5 1.5 0 000-3z"
          />
        </svg>
      </button>
    </div>

    <!--
            Dropdown menu, show/hide based on menu state.

            Entering: "transition ease-out duration-100"
              From: "transform opacity-0 scale-95"
              To: "transform opacity-100 scale-100"
            Leaving: "transition ease-in duration-75"
              From: "transform opacity-100 scale-100"
              To: "transform opacity-0 scale-95"
          -->
    <div
      class="absolute right-0 z-10 mt-2 w-36 origin-top-right rounded-md bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none"
      role="menu"
      v-show="isOpen"
      aria-orientation="vertical"
      aria-labelledby="menu-0-button"
      tabindex="-1"
    >
      <div class="py-1" role="none">
        <!-- Active: "bg-gray-100 text-white", Not Active: "text-gray-700" -->
        <a
          href="#"
          class="text-gray-700 block px-4 py-2 text-sm"
          role="menuitem"
          tabindex="-1"
          id="menu-0-item-0"
          >Editar</a
        >
        <a
          href="#"
          class="text-gray-700 block px-4 py-2 text-sm"
          role="menuitem"
          tabindex="-1"
          id="menu-0-item-1"
          >Cancelar</a
        >
      </div>
    </div>
  </div>
</template>