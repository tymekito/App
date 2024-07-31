import { defineComponent } from "vue";
import { useCounterStore } from "./stores/userStore";
import HelloWorld from "./components/HelloWorld.vue";
export default defineComponent({
    name: "App",
    components: {
        HelloWorld,
    },
    setup() {
        const counterStore = useCounterStore();
        return {
            counterStore,
        };
    },
});
;

function __VLS_template() {
    let __VLS_ctx;
    /* Components */
    let __VLS_otherComponents;
    let __VLS_own;
    let __VLS_localComponents;
    let __VLS_components;
    let __VLS_styleScopedClasses;
    // CSS variable injection 
    // CSS variable injection end 
    let __VLS_resolvedLocalAndGlobalComponents;
    __VLS_elementAsFunction(__VLS_intrinsicElements.div, __VLS_intrinsicElements.div)({});
    __VLS_elementAsFunction(__VLS_intrinsicElements.a, __VLS_intrinsicElements.a)({ href: ("https://vitejs.dev"), target: ("_blank"), });
    __VLS_elementAsFunction(__VLS_intrinsicElements.img)({ src: ("/vite.svg"), ...{ class: ("logo") }, alt: ("Vite logo"), });
    __VLS_elementAsFunction(__VLS_intrinsicElements.a, __VLS_intrinsicElements.a)({ href: ("https://vuejs.org/"), target: ("_blank"), });
    __VLS_elementAsFunction(__VLS_intrinsicElements.img)({ src: ("./assets/vue.svg"), ...{ class: ("logo vue") }, alt: ("Vue logo"), });
    // @ts-ignore
    const __VLS_0 = {}
        .HelloWorld;
    ({}.HelloWorld);
    __VLS_components.HelloWorld;
    // @ts-ignore
    [HelloWorld,];
    // @ts-ignore
    const __VLS_1 = __VLS_asFunctionalComponent(__VLS_0, new __VLS_0({ msg: ("Vite + Vue"), }));
    const __VLS_2 = __VLS_1({ msg: ("Vite + Vue"), }, ...__VLS_functionalComponentArgsRest(__VLS_1));
    ({}({ msg: ("Vite + Vue"), }));
    const __VLS_5 = __VLS_nonNullable(__VLS_pickFunctionalComponentCtx(__VLS_0, __VLS_2));
    if (typeof __VLS_styleScopedClasses === 'object' && !Array.isArray(__VLS_styleScopedClasses)) {
        __VLS_styleScopedClasses['logo'];
        __VLS_styleScopedClasses['logo'];
        __VLS_styleScopedClasses['vue'];
    }
    var __VLS_slots;
    return __VLS_slots;
    const __VLS_componentsOption = {
        HelloWorld,
    };
    const __VLS_name = "App";
    let __VLS_internalComponent;
}
