<script setup>
import { onMounted, ref } from 'vue'

const BASE = (import.meta.env.VITE_API_BASE || '').replace(/\/$/, '')

const message = ref('')
const error = ref('')

onMounted(async () => {
  try {
    const res = await fetch(BASE + '/api/hello')
    if (!res.ok) throw new Error(`HTTP ${res.status}`)
    const data = await res.json()
    message.value = data.message
  } catch (e) {
    error.value = e.message
  }
})
</script>

<template>
  <h1>CampusBook</h1>
  <p>API: {{ BASE || '(niet ingesteld)' }}</p>
  <p v-if="message">Antwoord: {{ message }}</p>
  <p v-else-if="error">Geen antwoord van de API: {{ error }}</p>
  <p v-else>Laden...</p>
</template>
