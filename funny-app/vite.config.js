"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const tslib_1 = require("tslib");
const vite_1 = require("vite");
const plugin_vue_1 = tslib_1.__importDefault(require("@vitejs/plugin-vue"));
const path_1 = tslib_1.__importDefault(require("path"));
exports.default = (0, vite_1.defineConfig)({
    plugins: [(0, plugin_vue_1.default)()],
    server: {
        host: "localhost",
        port: 8080,
    },
    resolve: {
        alias: {
            "@": path_1.default.resolve(__dirname, "./src"),
        },
    },
});
