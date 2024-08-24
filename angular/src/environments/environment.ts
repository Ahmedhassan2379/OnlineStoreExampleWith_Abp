import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AhmedHassan',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44333/',
    redirectUri: baseUrl,
    clientId: 'OnlineStoreExampleWith_Abp_App',
    responseType: 'code',
    scope: 'offline_access OnlineStoreExampleWith_Abp',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44333',
      rootNamespace: 'OnlineStoreExampleWith_Abp',
    },
  },
} as Environment;
