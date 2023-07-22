<template>
  <!-- Upcoming Step -->
  <a
    href="#"
    class="group flex flex-col border-l-4 border-gray-200 py-2 pl-4 hover:border-gray-300 md:border-l-0 md:border-t-4 md:pl-0 md:pt-4 md:pb-0"
  >
    <span class="text-sm font-medium text-gray-500 group-hover:text-gray-700">{{
      label
    }}</span>
  </a>
</template>

<script setup>
import { defineProps } from "vue";

const props = defineProps(["label"]);
</script>
