{
  description = "A very basic flake";
  inputs = {

    nixpkgs = {
      url = "github:anpin/nixpkgs?ref=next";
    };
  };
  outputs = { self, nixpkgs }: 
  let 
    system = "x86_64-linux";
    pkgs = import nixpkgs { 
      inherit system ; 
      # config = { allowUnfree = true; }; 
      # overlays = [ self.overlays.some-overlay]; 
    };
  in {
    devShells.${system}.default = pkgs.callPackage ./shell.nix { };
  };
}
