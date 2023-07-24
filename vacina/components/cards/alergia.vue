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
      <h3 class="pr-10 font-semibold text-white xl:pr-0">{{ item.nome }}</h3>
    </div>
    <menu-edit-cancel />
  </li>
</template>
