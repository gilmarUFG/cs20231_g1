<script setup>
import { defineProps } from "vue";

const props = defineProps(["currentStep", "steps"]);
const emits = defineEmits(["changeStep"]);

function changestep(stepSelecionada) {
  emits("changeStep", stepSelecionada);
}
</script>

<template>
  <nav aria-label="Progress">
    <ol role="list" class="space-y-4 md:flex md:space-y-0 md:space-x-8">
      <li v-for="step, index in steps" :key="step" @click="changestep(index)" class="md:flex-1">
        <steps-upcoming :label="step" v-if="currentStep < index" />
        <steps-completed :label="step" v-else-if="currentStep > index" />
        <steps-current :label="step" v-else />
      </li>
    </ol>
  </nav>
</template>
