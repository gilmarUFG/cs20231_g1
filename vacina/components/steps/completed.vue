<template>
  <a
    href="#"
    class="group flex flex-col border-l-4 border-blue-400 py-2 pl-4 hover:border-indigo-800 md:border-l-0 md:border-t-4 md:pl-0 md:pt-4 md:pb-0"
  >
    <span class="text-sm font-medium text-blue-400 group-hover:text-indigo-800"
      >{{ props.label }}</span
    >
  </a>
</template>

<script setup>
import { defineProps } from 'vue';

const props = defineProps(['label']);
</script>
