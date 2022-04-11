<template>
  <div class="d-flex flex-column pa-6">
    <div class="d-flex justify-space-between align-center mb-6">
      <div class="search-input">
        <v-icon>mdi-magnify </v-icon>
        <input placeholder="Procurar aluno"/>
      </div>
      <v-btn
        color="primary"
        elevation="5"
      >
        Cadastrar o aluno
      </v-btn>
    </div>
    <students-table />
  </div>
</template>

<script>
  import StudentsTable from '../components/StudentsTable.vue';
  export default {
    name: 'Home',
    components: { 
      StudentsTable,
    },
  }
</script>

<style>
  .search-input {
    display: flex;
    gap: 8px;
    padding: 0 4px;
    border: 1px solid;
    border-radius: 8px;
  }
  .search-input input:focus {
    outline: none;
  }
</style>