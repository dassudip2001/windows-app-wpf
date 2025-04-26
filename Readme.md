# WPF and Angular Desktop Application

This project is a hybrid desktop application that combines the power of **WPF (Windows Presentation Foundation)** for the desktop UI and **Angular** for the web-based UI. The application uses **WebView2** to embed the Angular application within the WPF application.

## Features

- **WPF Frontend**: Provides a native Windows desktop application experience.
- **Angular Integration**: Embeds a modern web-based UI using Angular.
- **WebView2**: Utilizes Microsoft Edge (Chromium) for rendering the Angular application.
- **Async Initialization**: Ensures smooth loading of the Angular app within the WPF application.

## Prerequisites

- **.NET Framework 4.7.2 or later** (for the WPF application)
- **Node.js** (for building the Angular application)
- **Microsoft Edge WebView2 Runtime** (required for WebView2)

## Project Structure

## Getting Started

### 1. Setting Up the Angular Application

1. Navigate to the `ui/` directory:
   ```bash
   cd ui
   ```
