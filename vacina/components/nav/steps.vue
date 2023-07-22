<script setup>
import { defineProps } from "vue";

const props = defineProps(["currentStep"]);

const emits = defineEmits(["changeStep"]);

function changestep(stepSelecionada) {
  emits("changeStep", stepSelecionada);
}
</script>

<template>
  <nav aria-label="Progress">
    <ol role="list" class="space-y-4 md:flex md:space-y-0 md:space-x-8">
      <li @click="changestep(1)" class="md:flex-1">
        <steps-completed label="Perfil" v-if="currentStep > 1" />
        <steps-current label="Perfil" v-else />
      </li>

      <li @click="changestep(2)" class="md:flex-1">
        <steps-upcoming label="Dados Pessoais" v-if="currentStep < 2" />
        <steps-completed label="Dados Pessoais" v-else-if="currentStep > 2" />
        <steps-current label="Dados Pessoais" v-else />
      </li>

      <li @click="changestep(3)" class="md:flex-1">
        <steps-upcoming label="Endereço" v-if="currentStep < 3" />
        <steps-completed label="Endereço" v-else-if="currentStep > 3" />
        <steps-current label="Endereço" v-else />
      </li>
    </ol>
  </nav>
</template>
