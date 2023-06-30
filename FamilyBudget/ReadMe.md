```csproj
    <Target Name="RunTailwindCSSWatch" BeforeTargets="Build">
        <Exec Command="npx tailwindcss -i .\wwwroot\css\tailwind.css -o .\wwwroot\css\tailwindStyles.css --watch --verbose" />
    </Target>
```

```bash
npx tailwindcss -i .\wwwroot\css\tailwind.css -o .\wwwroot\css\tailwindStyles.css --watch --verbose
```