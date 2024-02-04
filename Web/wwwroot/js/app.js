import about from '../../Pages/Components/v-about.vue';
const app = Vue.createApp({});

app.component('v-about', about);
console.log('Component v-about registered:', app.component('v-about'));


app.mount("#app");