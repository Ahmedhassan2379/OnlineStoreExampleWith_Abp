import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'OnlineStoreExampleWith_Abp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44333/',
    redirectUri: baseUrl,
    clientId: 'OnlineStoreExampleWith_Abp_App',
    responseType: 'code',
    scope: 'offline_access OnlineStoreExampleWith_Abp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44333',
      rootNamespace: 'OnlineStoreExampleWith_Abp',
    },
  },
} as Environment;
