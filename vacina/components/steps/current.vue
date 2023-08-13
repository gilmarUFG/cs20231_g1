<template>
  <!-- Current Step -->
  <a
    href="#"
    class="flex flex-col border-l-4 border-blue-400 py-2 pl-4 md:border-l-0 md:border-t-4 md:pl-0 md:pt-4 md:pb-0"
    aria-current="step"
  >
    <span class="text-sm font-medium text-blue-400">{{ label }}</span>
  </a>
</template>

<script setup>
import { defineProps } from "vue";

const props = defineProps(["label"]);
</script>
