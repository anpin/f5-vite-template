import { defineConfig } from 'vite'
import resolve from '@rollup/plugin-node-resolve'
export default defineConfig({
  logLevel: 'info',
  build: {
    input : './src/App.fs.js',
    cssCodeSplit: false,
    minify: false,
    minifySyntax: false,

    modulePreload : {
      polyfill: false
    },
    rollupOptions: {
      plugins: [
        resolve({
                modulePaths : [
                  'node_modules'
                ]
              }),
      ],
    },
  },
})
