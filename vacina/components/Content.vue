<!-- Please remove this file from your project -->
<template>
  <div id="content" class="h-screen flex flex-col items-center justify-between">
    <layout-Header />
    <div class="w-96">
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
