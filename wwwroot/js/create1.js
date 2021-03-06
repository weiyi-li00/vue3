
const options = {
  moduleCache: {
    vue: Vue
  },
  async getFile(url) {

    const res = await fetch(url);
    if ( !res.ok )
      throw Object.assign(new Error(res.statusText + ' ' + url), { res });
    return await res.text();
  },
  addStyle(textContent) {

  },
}

const { loadModule } = window['vue3-sfc-loader'];
const { ref , onMounted} = Vue;
const App = {
  data() {
    return {
      trage:""
    };
  },
     components:{
        //'cratetab':httpVueLoader('../crateTab.vue')
      'cratetab': Vue.defineAsyncComponent( () => loadModule('vue/crateTab.vue', options) ),
      'setting': Vue.defineAsyncComponent( () => loadModule('vue/setting.vue', options) ),
      'severce': Vue.defineAsyncComponent( () => loadModule('vue/severce.vue', options) ),
      'filed': Vue.defineAsyncComponent( () => loadModule('vue/filed.vue', options) )
     },
     
     methods: {
      //handleSelect(index) {
        // switch(index){
        //   case '1':
        //     $('#cratetab').show();
        //     $('#cratetab2').hide();
        //     break;
        //   case '2':
        //     $('#cratetab').hide();
        //     $('#cratetab2').show();
        //     break;
        // }
      //},頁籤的另一種寫法
      select(name){
        this.trage = name;
      }
      
    },
    created() {
      document.getElementById('app').style.display = '';
    },

};
  let app = Vue.createApp(App);
  app.use(ElementPlus);
  app.mount("#app");
  
