# 今日诗词 C# SDK

## 介绍

本项目原版来自 [今日诗词开放接口](https://www.jinrishici.com/)

## 安装

将本仓库克隆到本地，编译 **Jinrishici.SDK.Win**，将对应生成的 **Jinrishici.SDK.Win.dll** 引入到自己项目即可食用。

> 本项目代码是基于 **netstandard2.0** 而开发的，依赖 **Newtonsoft.Json**。

## 如何使用

### 获取 Token

```C#
await JinrishiciFactory.GetInstance().GetTokenAsync((d, ex) =>{ });
```

- d：从服务端获取到的 Token
- ex：异常信息

> 注：Token 用于鉴别和区分每个用户，获取后 永久有效，建议放到本地存储中；不同用户之间请不要使用同一个 Token；

### 请求数据

```C#
await JinrishiciFactory.GetInstance().GetSentenceAsync(token,(d, ex) =>{ });
```

- token：需要传递给服务端的 Token
- d：从服务端获取的推荐古诗
- ex：异常信息

### 其它版本

- [网站快速安装](https://www.jinrishici.com/doc/#json-fast)
- [小程序 SDK](https://www.jinrishici.com/doc/#mini-program)
- [NPM 快速安装](https://www.jinrishici.com/doc/#npm)
- [安卓 SDK](https://github.com/xenv/jinrishici-sdk-android/)

## License

[![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg)](https://github.com/996icu/996.ICU/blob/master/LICENSE)