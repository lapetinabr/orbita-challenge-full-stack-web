<template>
    <v-data-table
        :headers="headers"
        :items="initialData"
        :items-per-page="5"
        :loading="isDataLoading"
        class="elevation-1"
    >
    </v-data-table>
</template>

<script>
  import { api } from "../services/api" 
  export default {
    async mounted () {
        try {
            this.isDataLoading = true;
            await new Promise(resolve => setTimeout(resolve, 4000))
            const response = await api.get('/api/students');
            this.initialData = response.data.map(data => {
                return {
                    id: data.id,
                    ra: data.ra,
                    name: data.name,
                    cpf: data.social_identification,
                    action: <a>Editar</a>

                }
            })
        } catch(error) {
            console.log(error)
        } finally {
            this.isDataLoading = false;
        }
    },
    data () {
      return {
        headers: [
          {
            text: 'Registro Acadêmico',
            align: 'start',
            sortable: false,
            value: 'ra',
          },
          { text: 'Nome', value: 'name' },
          { text: 'CPF', value: 'cpf' },
          { text: 'Ações', value: 'action' },
        ],
        initialData: [],
        isDataLoading: false,
      }
    },
  }
</script>