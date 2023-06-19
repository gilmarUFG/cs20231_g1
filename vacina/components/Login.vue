<!-- Please remove this file from your project -->
<template>
  <div id="login" class="h-screen flex flex-col items-center justify-between">
    <layout-Header />
    <div class="w-2/4 bg-white shadow-lg rounded-3xl sm:w-full md:w-2/4 md:p-8 bg-clip-padding bg-opacity-60 border border-gray-200">
    <login-form
      :admin=props.admin
    />
    </div>
    <layout-Footer />
  </div>
</template>

<script setup>

const props = defineProps({
  admin: Boolean
});

</script>

<style>

#login {
  background-image: url('https://cdn.pixabay.com/photo/2019/10/12/18/07/syringe-4544448_1280.jpg');
  background-size: cover;
  background-position: center;
}

</style>