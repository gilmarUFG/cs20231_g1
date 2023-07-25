<script setup>
import { defineProps } from "vue";
import { HttpTransportType, HubConnection, HubConnectionBuilder } from "@aspnet/signalr";

const props = defineProps({
  agendas: {
    type: Object,
  },
});
</script>

<template>
  <div>
    <h2 class="text-lg font-semibold text-white">Agendamentos</h2>
    <div class="lg:grid lg:grid-cols-12 lg:gap-x-16">
      <ol
        class="mt-4 divide-y divide-gray-100 text-sm leading-6 col-span-12"
        v-for="agenda in agendas"
        :key="agenda.id"
      >
        <cards-agenda :item="agenda" />
      </ol>
    </div>
  </div>
</template>
