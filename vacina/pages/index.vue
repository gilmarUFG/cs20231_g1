<template>
  <div>
    <login
      :admin=false
    />
  </div>
</template>

<script setup>
import Vue, { onMounted, onUnmounted } from 'vue';

function verifyToken() {
  const token = localStorage.getItem('token');
  if (token) {
    return true;
  }
  return false;
}

onMounted(() => {
  if (verifyToken()) {
    window.location.href = '/agendamento';
  }
});
</script>
