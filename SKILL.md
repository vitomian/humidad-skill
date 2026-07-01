---
name: humidad
version: 1.2.0
description: HumiDAD is a desktop application development template generator that supports WPF+MaterialDesign and Avalonia+Fluent frameworks, helping developers quickly build professional desktop applications with SQLite database and login support.
description_zh: 桌面应用开发模板生成器，支持 WPF+MaterialDesign 和 Avalonia+Fluent 框架，快速生成带 SQLite 数据库和登录功能的专业桌面应用项目
description_en: Desktop application development template generator supporting WPF+MaterialDesign and Avalonia+Fluent frameworks, with SQLite database and login support
license: MIT
---

# HumiDAD - Desktop Application Development Skill

> Author: Trae | Version: 1.2.0

## Overview

HumiDAD is a professional desktop application development template generator that helps developers quickly build high-quality desktop applications.

## Features

### Platform Support

| Platform | Advantages |
|----------|------------|
| **Windows** | Native performance, rich Windows API support, MaterialDesign controls, Prism MVVM framework |
| **Avalonia** | Cross-platform (Windows/macOS/Linux), Fluent Design, modern UI controls |

### Layout Templates

| Template | Description | Regions |
|----------|-------------|---------|
| **Sidebar** | Suitable for admin panels, CRM systems | R1: LeftSidebar, R2: TopBar, R3: MainContent |
| **TopNav** | Suitable for document editors, utility software | R1: TopMenuBar, R2: MainContent |
| **Hybrid** | Suitable for IDEs, complex applications | R1: LeftSidebar, R2: TopBar, R3: MainContent, R4: StatusBar |
| **Tabbed** | Suitable for MDI applications | R1: TabBar, R2: MainContent |
| **Card** | Suitable for dashboards, data display | R1: TopNav, R2: CardArea |

### Theme Support

| Platform | Available Themes |
|----------|-----------------|
| **WPF** | Light, Dark, MaterialDesign2, MaterialDesign3 |
| **Avalonia** | Light, Dark, Fluent |

### Database Support

Automatic SQLite database creation with login support.

## Parameters

| Parameter | Type | Required | Default | Description |
|-----------|------|----------|---------|-------------|
| `targetPlatform` | string | Yes | - | Target platform: `Windows` or `Avalonia` |
| `uiLanguage` | string | No | `Chinese` | UI language: `Chinese` or `English` |
| `requireLogin` | boolean | No | `false` | Whether to include a login page |
| `layoutType` | string | Yes | - | Layout type: `Sidebar`, `TopNav`, `Hybrid`, `Tabbed`, `Card` |
| `themeStyle` | string | No | `Light` | Theme style (depends on platform) |

## Capabilities

- Platform selection (WPF / Avalonia)
- Language selection (Chinese / English)
- Login page generation
- Layout template generation (5 types)
- Theme customization
- Region-based content management
- Automatic project build
- Output management with executable location
- SQLite database setup

## Commands

| Command | Description | Usage |
|---------|-------------|-------|
| `/help` | Show all available commands | `/help` |
| `/style` | Show template regions and styles | `/style [template_name]` |
| `/region` | Show region details | `/region [region_id]` |
| `/result` | Show build output and executable location | `/result` |

## Workflow

1. Ask target platform (Windows / Avalonia)
2. Ask UI language (Chinese / English)
3. Ask login requirement (Yes / No)
4. Show layout options with preview guide
5. Show theme options
6. Generate project with SQLite database
7. Build project
8. Show output location and launch instructions

## Output Settings

- Build output path: `./Output/{platform}/{project_name}/{configuration}`
- Executable name: `{project_name}.exe`

## Platform Details

### Windows (WPF)
- Native performance
- Rich Windows API support
- MaterialDesign controls
- Prism MVVM framework

### Avalonia
- Write once, run everywhere
- Windows/macOS/Linux support
- Fluent Design
- Modern UI controls

## Version History

- **v1.2.0**: Added language selection, SQLite, UI improvements, layout preview
- **v1.1.0**: Added `/help` and `/result` commands
- **v1.0.0**: Initial release
