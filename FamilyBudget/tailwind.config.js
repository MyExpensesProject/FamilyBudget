module.exports = {
    mode: 'jit',
    content: [
        "./Areas/**/*.{cshtml,html,js,css}",
        "./Views/**/*.{cshtml,html,js,css}",
    ],
    plugins: [
        require('tailwindcss'),
        require('autoprefixer')
    ],
}