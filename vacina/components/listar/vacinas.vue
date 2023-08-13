<script setup>
import { ref, defineProps } from "vue";

const props = defineProps({
  vacinasList: {
    type: Array,
  },
});
</script>

<template>
  <div>
    <div class="lg:grid lg:grid-cols-12 lg:gap-x-16">
      <ol
        class="mt-4 divide-y divide-gray-100 text-sm leading-6 col-span-12"
        v-for="vacina in vacinasList"
        :key="vacina.id"
      >
        <cards-vacina :item="vacina" />
      </ol>
    </div>
  </div>
</template>
