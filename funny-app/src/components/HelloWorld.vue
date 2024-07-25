<!-- src/components/HelloWorld.vue -->
<template>
  <div>
    <h1>{{ msg }}</h1>
    <div class="card">
      <button type="button" @click="count++">count is {{ count }}</button>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";

// Define the component with TypeScript
export default defineComponent({
  name: "HelloWorld",
  props: {
    msg: {
      type: String,
      required: true,
    },
  },
  setup(props) {
    const count = ref(0);

    return {
      count,
      msg: props.msg,
    };
  },
});
</script>

<style scoped>
.card {
  /* Style for .card */
}
</style>
