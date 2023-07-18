<script setup>
import { defineProps } from 'vue';

const props = defineProps({
  user: {
    type: Object,
  },
});

</script>

<template>
  <div class="rounded-lg shadow-xl bg-gray-800 text-white" style="width: 450px">
    <div class="border-b border-gray-800 px-8 py-3">
      <div class="inline-block w-3 h-3 mr-2 rounded-full bg-red-500"></div>
      <div class="inline-block w-3 h-3 mr-2 rounded-full bg-yellow-300"></div>
      <div class="inline-block w-3 h-3 mr-2 rounded-full bg-green-400"></div>
    </div>
    <div class="px-8 py-6">
      <p>
        <em class="text-blue-400">const</em> <span class="text-green-400">aboutMe</span>
        <span class="text-pink-500">=</span> <em class="text-blue-400">function</em>() {
      </p>
      <p>&nbsp;&nbsp;<span class="text-pink-500">return</span> {</p>
      <p>
        &nbsp;&nbsp;&nbsp;&nbsp;name: <span class="text-yellow-300">'{{ user.nome }}'</span>,
      </p>
      <p>
        &nbsp;&nbsp;&nbsp;&nbsp;admin:
        <span class="text-yellow-300">'{{ user.isAdmin }}'</span>,
      </p>
      <p>
        &nbsp;&nbsp;&nbsp;&nbsp;email:
        <span class="text-yellow-300"
          >'<a
            :href="'mailto:' + user.email"
            target="_blank"
            class="text-yellow-300 hover:underline focus:border-none"
            >{{user.email}}</a
          >'</span
        >,
      </p>
      <p>&nbsp;&nbsp;}</p>
      <p>}</p>
    </div>
  </div>
</template>
