# PerfectFifth Minimal App

This is a small Fable app project with PerfectFifth p5.js to F# bindings and vite devserver. For now it references `PerfectFifth` fork as submodule and to facilitate upstream development. 

## Run it in a few steps

-  get this repo with submodules
    ```
    git clone https://github.com/anpin/f5-vite-template
    cd f5-vite-template
    git pull --recurse-submodules
    ```

- get into nix shell with all the tools  (you can skip this step)
    ```
    nix develop
    ```

- if you skipped above step you might need 
    ```
    dotnet tool restore 
    ```
- build nuget from submodule
    ```
    dotnet pack perfect-fifth/src -o perfect-fifth/result
    ```

- run dev server
    ```
    yarn start 

    ```
- change some code in `src/App.fs` and see the change
- if reload is not happening do `dotnet fable clean src`