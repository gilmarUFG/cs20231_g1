<script setup>
import { ref } from "vue";
const menuIsOpen = ref(false);

function toggleMenu() {
  menuIsOpen.value = !menuIsOpen.value;
}
</script>

<template>
  <div>
    <div
      @click="toggleMenu"
      class="fixed bottom-4 right-1 md:bottom-4 md:right-4 cursor-pointer z-20 flex items-center justify-center h-12 w-12 rounded-full bg-gray-600 text-white p-2 shadow-lg hover:shadow-xl transition-shadow duration-300 ease-in-out"
    >
      <svg
        xmlns="http://www.w3.org/2000/svg"
        fill="none"
        viewBox="0 0 24 24"
        strokeWidth="{1.5}"
        stroke="currentColor"
        className="w-6 h-6"
      >
        <path
          strokeLinecap="round"
          strokeLinejoin="round"
          d="M3.75 6.75h16.5M3.75 12h16.5m-16.5 5.25h16.5"
        />
      </svg>
    </div>
    <cards-search v-show="menuIsOpen" />
  </div>
</template>
