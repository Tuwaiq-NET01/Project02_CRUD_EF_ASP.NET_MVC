function start() {
    document.getElementById("searchbtn").onclick = () => {
        window.location.href = "https://localhost:5001/anime/search?animeName=" + document.getElementById("searchname").value
    }
}

const addfav = async (id) => {
    document.getElementById("popup").style.opacity = "1"
    await fetch("https://localhost:5001/users/addFav/1?animeid=" + id)
    window.setTimeout(() => {
        document.getElementById("popup").style.opacity = "0"
    }, 3000)
}

const removefav = async (id) => {
    document.getElementById("popupre").style.opacity = "1"
    await fetch("https://localhost:5001/users/removeFav/1?animeid=" + id)
    window.setTimeout(() => {
        document.getElementById("popupre").style.opacity = "0"
    }, 3000)
}
const modalhandling = async (id) => {
    
    const response = await fetch("https://localhost:5001/anime/Getanimee/"+id)
    const anime = await response.json()
    console.log(anime)

    document.getElementById("idd").value = anime.id
    document.getElementById("tit").value = anime.title
    document.getElementById("img").value = anime.image_url
    document.getElementById("urll").value = anime.url
    document.getElementById("typee").value = anime.type
    document.getElementById("ep").value = anime.episodes
    document.getElementById("sd").value = anime.start_date
    document.getElementById("ed").value = anime.end_date
    document.getElementById("scoree").value = anime.score
    document.getElementById("cat").value = anime.categoryid

}
window.addEventListener("load", start)