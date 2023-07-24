<script setup>
import { ref, defineProps } from "vue";

const props = defineProps({
  alergiasList: {
    type: Array,
  },
});
</script>

<template>
  <div>
    <div class="lg:grid lg:grid-cols-12 lg:gap-x-16">
      <ol
        class="mt-4 divide-y divide-gray-100 text-sm leading-6 col-span-12"
        v-for="alergia in alergiasList"
        :key="alergia.id"
      >
        <cards-alergia :item="alergia" />
      </ol>
    </div>
  </div>
</template>
