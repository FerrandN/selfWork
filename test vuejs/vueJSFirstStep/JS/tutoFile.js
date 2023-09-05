import { createApp } from 'vue'

const app = createApp({
  /* root component options */
})

app.mount('#app')
app.config.errorHandler = (err) => {
    /* handle error */
  }
  app.component('TodoDeleteButton', TodoDeleteButton)