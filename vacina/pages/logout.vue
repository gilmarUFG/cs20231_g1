<script setup>
onMounted(() => {
  localStorage.removeItem("token");
  localStorage.removeItem("user");
  localStorage.removeItem("admin");
  window.location.href = "/login";
});
</script>

<template>
  <load />
</template>
