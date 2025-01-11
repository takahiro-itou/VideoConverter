
msbuild -restore -t:Rebuild -p:Configuration="Release" -p:Platform=x86  ^
    -p:TargetFrameworks=net6.0-windows  Net60.sln
