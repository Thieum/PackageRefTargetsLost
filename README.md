# PackageRefTargetsLost
 Repro projects for issue with package reference and native deps/targets

ProxyDLL -> reference a nuget with native dependencies, create a package.

Consumer -> consumes the proxyDLL. Will build but fail at runtime, as transitive native dependencies will be missing.
