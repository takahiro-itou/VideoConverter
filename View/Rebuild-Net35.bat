
msbuild -restore -t:Rebuild -p:Configuration="Release" -p:Platform=x86  ^
    -p:TargetFrameworks=net3.5  Net35.sln
