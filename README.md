# HumiDAD - Desktop Application Development Skill

> 专业的桌面应用开发模板生成器，支持 WPF+MaterialDesign 和 Avalonia+Fluent 框架

## Features

- **Platform Support**: WPF (Windows native) and Avalonia (cross-platform)
- **Layout Templates**: Sidebar, TopNav, Hybrid, Tabbed, Card
- **Theme Support**: Light, Dark, MaterialDesign, Fluent
- **Database**: SQLite with EF Core integration
- **Login System**: Built-in authentication support
- **MVVM**: Prism and CommunityToolkit.Mvvm frameworks

## Platform Comparison

| Platform | Advantages | Framework |
|----------|------------|-----------|
| **WPF** | Native performance, rich Windows API | MaterialDesign + Prism |
| **Avalonia** | Cross-platform (Windows/macOS/Linux) | Fluent Design |

## Layout Templates

| Template | Description | Regions |
|----------|-------------|---------|
| **Sidebar** | Admin panels, CRM systems | LeftSidebar, TopBar, MainContent |
| **TopNav** | Document editors, utilities | TopMenuBar, MainContent |
| **Hybrid** | IDEs, complex applications | LeftSidebar, TopBar, MainContent, StatusBar |
| **Tabbed** | MDI applications | TabBar, MainContent |
| **Card** | Dashboards, data display | TopNav, CardArea |

## Project Structure

```
humidad-skill/
├── SKILL.md                    # Skill definition (required for Trae IDE)
├── Templates/
│   ├── AvaloniaSemi/           # Avalonia templates (6 types)
│   │   ├── Layout1_Sidebar/
│   │   ├── Layout2_TopNav/
│   │   ├── Layout3_Hybrid/
│   │   ├── Layout4_Tabbed/
│   │   ├── Layout5_Card/
│   │   └── LoginTemplate/
│   └── WpfMaterialDesign/      # WPF templates (6 types)
│       ├── Layout1_Sidebar/
│       ├── Layout2_TopNav/
│       ├── Layout3_Hybrid/
│       ├── Layout4_Tabbed/
│       ├── Layout5_Card/
│       └── LoginTemplate/
├── .gitignore
├── LICENSE
└── README.md
```

## Prerequisites

### Required

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

### Optional Development Tools

You can choose any of the following IDEs based on your platform and preference:

| Tool | Platform | WPF Support | Avalonia Support | Recommendation |
|------|----------|-------------|------------------|----------------|
| [Visual Studio 2022](https://visualstudio.microsoft.com/) | Windows | ✅ Full | ✅ (with extension) | Windows + WPF |
| [JetBrains Rider](https://www.jetbrains.com/rider/) | Windows/macOS/Linux | ✅ Full | ✅ Native | Cross-platform |
| [Visual Studio Code](https://code.visualstudio.com/) | Windows/macOS/Linux | ⚠️ Limited | ✅ (with extension) | Lightweight |
| [.NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/) | Windows/macOS/Linux | ✅ (no designer) | ✅ (no designer) | Command-line only |

> **Note**: Visual Studio 2022 is NOT required. You can use any IDE that supports .NET development.

### AI IDEs (for using as a Skill)

One of the following AI IDEs (optional, required only for Skill functionality):

- [Trae IDE](https://trae-ide.com/)
- [CodeX IDE](https://codex.ide/)
- [CodeBuddy IDE](https://codebuddy.ai/)
- [ClaudeCode](https://claude.ai/claudecode)

---

## Installation Methods

### Method 1: Use as Trae IDE Skill

This is the recommended way to use HumiDAD if you have Trae IDE installed.

#### Step 1: Clone the Repository

```bash
git clone https://github.com/your-username/humidad-skill.git
cd humidad-skill
```

#### Step 2: Install to Trae IDE

1. Open Trae IDE
2. Open the **Skill Manager** (usually via `Ctrl+Shift+P` → "Skill Manager")
3. Click **Import Skill**
4. Select the `humidad-skill` directory (the one containing `SKILL.md`)
5. Click **OK** to install

#### Step 3: Verify Installation

1. Restart Trae IDE
2. Open a new chat
3. Type `/help` to see available commands
4. You should see HumiDAD commands in the list

#### Step 4: Use the Skill

1. Type `/humidad` in the chat to start
2. Follow the interactive prompts:
   - Select target platform (Windows/Avalonia)
   - Select UI language (Chinese/English)
   - Select login requirement (Yes/No)
   - Select layout type (Sidebar/TopNav/Hybrid/Tabbed/Card)
   - Select theme style (Light/Dark)
3. The skill will generate a complete project for you

---

### Method 2: Use as CodeX IDE Skill

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/humidad-skill.git
   ```

2. Open CodeX IDE

3. Go to **Extensions** → **Skills**

4. Click **Add Skill** → **From Directory**

5. Select the `humidad-skill` directory

6. Restart CodeX IDE

7. Type `/humidad` in the chat to use the skill

---

### Method 3: Use as CodeBuddy IDE Skill

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/humidad-skill.git
   ```

2. Open CodeBuddy IDE

3. Click on the **Skills** tab in the sidebar

4. Click **Import Skill**

5. Select the `humidad-skill` directory (containing `SKILL.md`)

6. Click **Install**

7. Restart CodeBuddy IDE

8. Use the skill by typing `/humidad` in the chat

---

### Method 4: Use as ClaudeCode Skill

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/humidad-skill.git
   ```

2. Open ClaudeCode

3. Go to **Settings** → **Extensions** → **Skills**

4. Click **Add Custom Skill**

5. Select the `humidad-skill` directory

6. Click **Load Skill**

7. Type `/humidad` in the chat to start using the skill

---

### Method 5: Use as Template Project Directly

If you don't use any AI IDE, you can use the templates directly without installing as a skill.

#### Step 1: Clone the Repository

```bash
git clone https://github.com/your-username/humidad-skill.git
cd humidad-skill
```

#### Step 2: Select a Template

Navigate to the template you want to use:

**For WPF + MaterialDesign:**
```bash
cd Templates/WpfMaterialDesign/Layout1_Sidebar/
```

**For Avalonia:**
```bash
cd Templates/AvaloniaSemi/Layout1_Sidebar/
```

#### Step 3: Rename the Project (Optional but Recommended)

1. Open `Layout1_Sidebar.csproj` in a text editor
2. Change the assembly name and root namespace to your project name
3. Rename the `.csproj` file to match your project name

#### Step 4: Build and Run

**Using .NET CLI:**
```bash
dotnet restore
dotnet build
dotnet run
```

**Using Visual Studio:**
1. Open the `.csproj` file in Visual Studio
2. Wait for NuGet packages to restore
3. Click **Start Debugging** (F5)

---

### Method 6: Download from GitHub Releases

1. Go to the [Releases](https://github.com/your-username/humidad-skill/releases) page
2. Download the latest release zip
3. Extract the files to your preferred location
4. Follow Method 1 or Method 2 above

---

## Default Credentials

All templates come with a default user for demonstration:

```
Username: 123
Password: 123
```

> **Important**: This is for demonstration purposes only. 
> **Never use these credentials in production.**
> Change the default password in `AppDbContext.cs` before deploying.

## Parameters

| Parameter | Type | Required | Default | Description |
|-----------|------|----------|---------|-------------|
| `targetPlatform` | string | Yes | - | Target platform: `Windows` or `Avalonia` |
| `uiLanguage` | string | No | `Chinese` | UI language: `Chinese` or `English` |
| `requireLogin` | boolean | No | `false` | Whether to include a login page |
| `layoutType` | string | Yes | - | Layout type: `Sidebar`, `TopNav`, `Hybrid`, `Tabbed`, `Card` |
| `themeStyle` | string | No | `Light` | Theme style (depends on platform) |

## Commands (Trae IDE Only)

| Command | Description | Usage |
|---------|-------------|-------|
| `/help` | Show all available commands | `/help` |
| `/style [template]` | Show template regions and styles | `/style Sidebar` |
| `/region [id]` | Show region details | `/region LeftSidebar` |
| `/result` | Show build output and executable location | `/result` |

## Skill Workflow (Trae IDE)

When using `/humidad` command:

1. **Platform Selection**: Choose between Windows (WPF) or Avalonia
2. **Language Selection**: Choose Chinese or English UI
3. **Login Configuration**: Enable/disable login page
4. **Layout Selection**: Choose from 5 layout templates with preview guide
5. **Theme Selection**: Choose Light or Dark theme
6. **Project Generation**: Skill generates the complete project
7. **Database Setup**: SQLite database with default user is created
8. **Build Execution**: Project is built automatically
9. **Result Display**: Output location and launch instructions are shown

## Database Setup

All WPF templates include SQLite database support:

- Database file: `app.db` (created in the application directory)
- ORM: Entity Framework Core
- Default table: `Users` with username and password fields
- Automatic database creation on first run

**Note**: Avalonia templates do not include database integration by default. You can add it by copying the `AppDbContext.cs` from WPF templates.

## Version History

- **v1.2.0**: Added language selection, SQLite, UI improvements, layout preview
- **v1.1.0**: Added `/help` and `/result` commands
- **v1.0.0**: Initial release

## License

MIT License - see [LICENSE](LICENSE) for details

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Author

Trae
