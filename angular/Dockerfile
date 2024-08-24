FROM node:alpine:3.19 as build
RUN mkdir -p /app

WORKDIR /app

COPY package.json /app/
RUN npm install

COPY . /app/
RUN npm run build --prod

FROM nginx:1.27.0-alpine-slim
COPY --from=build /app/dist/angular/usr/share/nginx/html