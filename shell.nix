{ pkgs  } : with pkgs;
mkShell {
  packages = [
   dotnet-sdk_7
   nuget-to-nix
   fable
   nodejs-16_x
   yarn
   yarn2nix
  ];
}
