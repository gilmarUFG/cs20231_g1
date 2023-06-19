import Vue from 'vue'
import Router from 'vue-router'
import { normalizeURL, decode } from 'ufo'
import { interopDefault } from './utils'
import scrollBehavior from './router.scrollBehavior.js'

const _94b89c8e = () => interopDefault(import('../pages/agendamento.vue' /* webpackChunkName: "pages/agendamento" */))
const _d0a44d00 = () => interopDefault(import('../pages/vacina.vue' /* webpackChunkName: "pages/vacina" */))
const _758b6b9a = () => interopDefault(import('../pages/cerberus/login.vue' /* webpackChunkName: "pages/cerberus/login" */))
const _5891bdc9 = () => interopDefault(import('../pages/cerberus/register.vue' /* webpackChunkName: "pages/cerberus/register" */))
const _34745ec6 = () => interopDefault(import('../pages/index.vue' /* webpackChunkName: "pages/index" */))

const emptyFn = () => {}

Vue.use(Router)

export const routerOptions = {
  mode: 'history',
  base: '/',
  linkActiveClass: 'nuxt-link-active',
  linkExactActiveClass: 'nuxt-link-exact-active',
  scrollBehavior,

  routes: [{
    path: "/agendamento",
    component: _94b89c8e,
    name: "agendamento"
  }, {
    path: "/vacina",
    component: _d0a44d00,
    name: "vacina"
  }, {
    path: "/cerberus/login",
    component: _758b6b9a,
    name: "cerberus-login"
  }, {
    path: "/cerberus/register",
    component: _5891bdc9,
    name: "cerberus-register"
  }, {
    path: "/",
    component: _34745ec6,
    name: "index"
  }],

  fallback: false
}

export function createRouter (ssrContext, config) {
  const base = (config._app && config._app.basePath) || routerOptions.base
  const router = new Router({ ...routerOptions, base  })

  // TODO: remove in Nuxt 3
  const originalPush = router.push
  router.push = function push (location, onComplete = emptyFn, onAbort) {
    return originalPush.call(this, location, onComplete, onAbort)
  }

  const resolve = router.resolve.bind(router)
  router.resolve = (to, current, append) => {
    if (typeof to === 'string') {
      to = normalizeURL(to)
    }
    return resolve(to, current, append)
  }

  return router
}
