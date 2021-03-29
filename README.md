# PackageRefTargetsLost
 Repro projects for issue with package reference and native deps/targets

ProxyDLL -> reference a nuget with native dependencies, create a package.

Consumer -> consumes the proxyDLL. Will build but fail at runtime, as transitive native dependencies will be missing.

Steps to reproduce :

1. Build ProxyDLL in release mode to generate the nuget package.
2. Build the consumer to retrieve the package.
3. Try to run Consumer. if will fail with a FileNotFoundException (on a native dependency)
4. If you add a reference to CefSharp.OffScreen in Consumer, it should run.
