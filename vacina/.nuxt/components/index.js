export { default as Agendamento } from '../../components/Agendamento.vue'
export { default as Content } from '../../components/Content.vue'
export { default as Login } from '../../components/Login.vue'
export { default as NuxtLogo } from '../../components/NuxtLogo.vue'
export { default as Register } from '../../components/Register.vue'
export { default as VacinaRoot } from '../../components/VacinaRoot.vue'
export { default as FormsAgendamento } from '../../components/Forms/agendamento.vue'
export { default as FormsVacina } from '../../components/Forms/vacina.vue'
export { default as GlobalButton } from '../../components/Global/Button.vue'
export { default as IndexsVacina } from '../../components/Indexs/vacina.vue'
export { default as MenuFloat } from '../../components/Menu/Float.vue'
export { default as MenuSidebar } from '../../components/Menu/Sidebar.vue'
export { default as ModalPattern } from '../../components/Modal/Pattern.vue'
export { default as LayoutFooter } from '../../components/layout/Footer.vue'
export { default as LayoutHeader } from '../../components/layout/Header.vue'
export { default as LoginForm } from '../../components/login/Form.vue'
export { default as LoginRegister } from '../../components/login/Register.vue'

// nuxt/nuxt.js#8607
function wrapFunctional(options) {
  if (!options || !options.functional) {
    return options
  }

  const propKeys = Array.isArray(options.props) ? options.props : Object.keys(options.props || {})

  return {
    render(h) {
      const attrs = {}
      const props = {}

      for (const key in this.$attrs) {
        if (propKeys.includes(key)) {
          props[key] = this.$attrs[key]
        } else {
          attrs[key] = this.$attrs[key]
        }
      }

      return h(options, {
        on: this.$listeners,
        attrs,
        props,
        scopedSlots: this.$scopedSlots,
      }, this.$slots.default)
    }
  }
}
