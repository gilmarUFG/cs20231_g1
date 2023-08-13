<template>
  <ul role="list" class="divide-y divide-gray-100">
    <li v-for="scheduler in agenda" :key="scheduler.email" class="flex justify-between gap-x-6 py-5">
      <div class="flex gap-x-4">
        <img class="h-12 w-12 flex-none rounded-full bg-gray-50" :src="scheduler.imageUrl" alt="" />
        <div class="min-w-0 flex-auto">
          <p class="text-sm font-semibold leading-6 text-white">{{ scheduler.name }}</p>
          <p class="mt-1 truncate text-xs leading-5 text-gray-400">{{ scheduler.email }}</p>
        </div>
      </div>
      <div class="hidden sm:flex sm:flex-col sm:items-end">
        <p class="text-sm leading-6 text-white">{{ scheduler.role }}</p>
        <p v-if="scheduler.lastSeen" class="mt-1 text-xs leading-5 text-gray-400">
          Last seen <time :datetime="scheduler.lastSeenDateTime">{{ scheduler.lastSeen }}</time>
        </p>
        <div v-else class="mt-1 flex items-center gap-x-1.5">
          <div class="flex-none rounded-full bg-emerald-500/20 p-1">
            <div class="h-1.5 w-1.5 rounded-full bg-emerald-500" />
          </div>
          <p class="text-xs leading-5 text-gray-400">Online</p>
        </div>
      </div>
    </li>
  </ul>
</template>

<script setup>
import { ref, defineProps } from "vue";

const props = defineProps({
  agenda: {
    type: Array,
    required: true,
  },
});


</script>